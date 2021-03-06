﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NackademinUppgift05.UI
{
	public partial class AnimalPage : Form
	{
		public readonly ZoophobiaContainer zoo;

		public Animal Animal { get; }
		public readonly bool isNew;

		private readonly List<Animal> allAnimals;

		public AnimalPage(ZoophobiaContainer zoo, Animal animal = null)
		{
			isNew = animal == null;
			Animal = animal ?? new Animal();

			this.zoo = zoo;
			allAnimals = zoo.Animals
				.Include(a => a.Species)
				.Include(a => a.AnimalParents)
				.ToList();

			InitializeComponent();
		}
		
		private void AnimalPage_Load(object sender, EventArgs e)
		{
			if (!isNew)
				this.Text = "Change animal info";

			animalNameTextBox.Text = Animal.Name;
			animalOriginTextBox.Text = Animal.Origin;
			animalWeightTextBox.Text = Animal.Weight.ToString(CultureInfo.CurrentCulture);
			animalSpeciesComboBox.SelectedSpecies = Animal.Species;

			UpdateParentsList();
		}

		private void UpdateParentsList()
		{
			animalParentsListBox.Items.Clear();
			animalParentsListBox.Items.AddRange(Animal.AnimalParents.ToArray());
			animalParentsComboBox.Items.Clear();

			animalParentsComboBox.Items.AddRange(allAnimals
				.Where(a => !Animal.AnimalParents.Any(a2 => a2.ParentId == a.Id))
				.ToArray());
		}

		private void animalWeightTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (double.TryParse(animalWeightTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out double weight))
			{
				animalWeightTextBox.Text = weight.ToString(CultureInfo.CurrentCulture);
				Animal.Weight = weight;
			}
			else
			{
				animalWeightTextBox.Text = Animal.Weight.ToString(CultureInfo.CurrentCulture);
			}
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Animal.Name))
				return;
			if (string.IsNullOrWhiteSpace(Animal.Origin))
				return;
			Species species = animalSpeciesComboBox.SelectedSpecies;
			if (species == null)
				return;
			Animal.Species = species;

			// Save changes
			if (isNew)
			{
				zoo.Animals.Add(Animal);
			}

			zoo.SaveChanges();
			
			DialogResult = DialogResult.OK;
			Close();
		}

		private void animalParentsRemoveButton_Click(object sender, EventArgs e)
		{
			if (!(animalParentsListBox.SelectedItem is AnimalParent parent))
				return;

			Animal.AnimalParents.Remove(parent);
			UpdateParentsList();
		}

		private void animalParentsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!(animalParentsComboBox.SelectedItem is Animal parent))
				return;

			var parenting = new AnimalParent
			{
				ChildId = Animal.Id,
				Child = Animal,
				ParentId = parent.Id,
				Parent = parent,
			};

			Animal.AnimalParents.Add(parenting);

			UpdateParentsList();
		}

		private void animalNameTextBox_TextChanged(object sender, EventArgs e)
		{
			Animal.Name = animalNameTextBox.Text.Trim();
		}

		private void animalOriginTextBox_TextChanged(object sender, EventArgs e)
		{
			Animal.Origin = animalOriginTextBox.Text.Trim();
		}

		private void animalParentsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			animalParentsRemoveButton.Enabled = animalParentsListBox.SelectedItem is AnimalParent;
		}
	}
}
