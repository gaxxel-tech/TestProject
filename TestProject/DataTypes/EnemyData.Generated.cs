#pragma warning disable

namespace TestProject.DataTypes
{
    public partial class EnemyData
    {
        public string ID;
        public float Health;
        public float Speed;
        public int Damage;
        public int Level;
        public const string Slime = "Slime";
        public const string Gulpin = "Gulpin";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Slime
        ,Gulpin
        };
        
        
    }
}
