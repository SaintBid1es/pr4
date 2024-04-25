using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4
{
    class PropertyTest
    {
        public string Name { get; set; }
        public string Description {  get; set; }
        public string First_variant {  get; set; }
        public string Two_variant {  get; set; }
        public string Three_variant {  get; set; }
        public RightVariant True_variant {  get; set; }
        
        public PropertyTest( string name,  string description,  string first_variant, string two_variant, string three_variant)
        {
            Name = name;
            Description = description;
            First_variant = first_variant;
            Two_variant = two_variant;
            Three_variant = three_variant;
            True_variant = RightVariant.первый;
        }
        public PropertyTest() { }










    }
}
