using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBunny.basedata
{
    class AppData
    {
        public static Staff staffSave = new Staff();
        public static Order orderSave = new Order();
        public static GoldBunnyEntities bd_gold = new GoldBunnyEntities();
        public static Pet petSave = new Pet();
        public static Medcard medcardSave = new Medcard();
        public static Client clientSave = new Client();
        public static Service serviceSave = new Service();
        public static int iDOrder;
        public static int IDClientSave;
        public static int IDPetSave;
    }
}
