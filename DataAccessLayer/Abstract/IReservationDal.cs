using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
   public interface IReservationDal:IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
    }
}
