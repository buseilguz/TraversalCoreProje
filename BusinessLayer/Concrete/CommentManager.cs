using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
  public  class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void TAdd(Comment t)
        {
            _commentdal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new NotImplementedException();
        }
        public List<Comment> TGetDestinationById(int id)
        {
            return _commentdal.GetListByFilter(x => x.DestinationId == id);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
