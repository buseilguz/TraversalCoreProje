using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
    }
}
