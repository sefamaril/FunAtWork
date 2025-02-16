using FunAtWork.Core.Common;

namespace FunAtWork.Core.Entities
{
    public class ContestType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ScoringSystem { get; set; }
        public string ContestFormat { get; set; }
        public string ContestLevel { get; set; }
        public string ContestObjectives { get; set; }
        public string ContestMaterials { get; set; }
    }
}