using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public static class DataSeed
    {
        public static List<HajsorobBase> Data = new List<HajsorobBase>()
        {
            new HajsorobBase{ Id = 1,
                Name = "Marchewki", Amount = 1, BaseMoney=1, BasePrice=5, PriceModifier=2,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=1f },
            new HajsorobBase{ Id = 2,
                Name = "Soki owocowe", Amount = 0, BaseMoney=2, BasePrice=10, PriceModifier=4,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=3f },
            new HajsorobBase{ Id=3,
                Name = "Ciastka", Amount = 0, BaseMoney=5, BasePrice=20, PriceModifier=10,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=10f },
            new HajsorobBase{ Id=4,
                Name = "Lody owocowe", Amount = 0, BaseMoney=10, BasePrice=50, PriceModifier=20,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=25f },
            new HajsorobBase{ Id=5,
                Name = "Ciasta owocowe", Amount = 0, BaseMoney=20, BasePrice=150, PriceModifier=40,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=60f },
            new HajsorobBase{ Id=6,
                Name = "Nadowoc", Amount = 0, BaseMoney=50, BasePrice=500, PriceModifier=200,  MilestoneBase=10, MilestoneLevel=0, MilestoneModifier = 10, BaseProductionTime=120f }

        };
    }

    public class HajsorobBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int MilestoneLevel { get; set; }
        public int MilestoneBase { get; set; }
        public int MilestoneModifier { get; set; }

        public int BaseMoney { get; set; }
        public int BasePrice { get; set; }

        public int PriceModifier { get; set; }
        public float BaseProductionTime { get; set; }
    }
}
