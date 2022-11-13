using WorldVision.BussinesLogic.Interfaces;
using WorldVision.BussinesLogic.LoginBL;
using WorldVision.BussinesLogic.Interfaces;

namespace WorldVision.BussinesLogic
{
    public class BussinesLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }
        public IGalerie GetGalerieBL()
        {
            return new GalerieBL();
        }

       

    }
}
