//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH_TPA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingredient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredient()
        {
            this.RecipeDish = new HashSet<RecipeDish>();
            this.RecipeFood = new HashSet<RecipeFood>();
        }
    
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public int IngredientStock { get; set; }
        public int IngredientMinimumStock { get; set; }
        public int IngredientPrice { get; set; }
        public int Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeDish> RecipeDish { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeFood> RecipeFood { get; set; }
    }
}
