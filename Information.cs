using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Wiki Application Information Class
/// 
/// © Bruce Fisher P197681
/// 20-2-2022 
/// Version 1.1
/// 
/// Implements IComparable
/// •	As using objects, the .Net Sort method cannot deal with Complex Types i.e., Objects.
/// •	Therefore, need to define the Class with IComparable which will allow each instance 
/// 	of the Object defined Attribute to be compared with one another.
/// 
/// Implements Serializable
/// •   Used to convert object to byte stream to write/read for binary file
/// </summary>

namespace WikiApplication
{
    [Serializable]
    internal class Information : IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Information()
        {

        }

        /// <summary>
        /// Sets Attributes for each new Instance created
        /// </summary>
        /// <param name="newName">New Wiki name</param>
        /// <param name="newCategory">New Wiki catergory</param>
        /// <param name="newStructure">New Wiki structure</param>
        /// <param name="newDefinition">New Wiki definition</param>
        public Information(string newName, string newCategory, string newStructure, string newDefinition)
        {
            name = newName;
            category = newCategory;
            structure = newStructure;
            definition = newDefinition;
        }

        /// <summary>
        ///  Setter for name
        /// </summary>
        /// <param name="name">string to set name</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Getter for name
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Setter for category
        /// </summary>
        /// <param name="category">string to set category</param>
        public void SetCategory(string category)
        {
            this.category = category;
        }

        /// <summary>
        /// Getter for category
        /// </summary>
        /// <returns>category</returns>
        public string GetCatergory()
        {
            return category;
        }

        /// <summary>
        /// Setter for structure
        /// </summary>
        /// <param name="structure">string to set structure</param>
        public void SetStructure(string structure)
        {
            this.structure = structure;
        }

        /// <summary>
        /// Getter for structure
        /// </summary>
        /// <returns>structure</returns>
        public string GetStructure()
        {
            return structure;
        }

        /// <summary>
        /// Setter for definition
        /// </summary>
        /// <param name="definition">string to set definition</param>
        public void SetDefinition(string definition)
        {
            this.definition = definition;
        }

        /// <summary>
        /// Getter for definition
        /// </summary>
        /// <returns>definition</returns>
        public string GetDefinition()
        {
            return definition;
        }

        /// <summary>
        /// Compare the current instance to another instance
        /// </summary>
        /// <param name="otherName">Attribute to compare with "name"</param>
        /// <returns>Integer which shows whether the value of the current instance is greater than, 
        /// equal to, or less than the value of the other instance</returns>

        public int CompareTo(Information otherName)
        {
            return this.name.CompareTo(otherName.name); // Attribute to compare with "name"
        }
    }
}
