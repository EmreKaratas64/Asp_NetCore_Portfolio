﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListInBox(string p)
        {
            return _writerMessageDal.GetByFilter(r => r.Receiver == p);
        }

        public List<WriterMessage> GetListSendBox(string p)
        {
            return _writerMessageDal.GetByFilter(r => r.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writerMessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            _writerMessageDal.Delete(t);
        }

        public List<WriterMessage> TGetByFilter()
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetByID(int id)
        {
            return _writerMessageDal.GetByID(id);
        }

        public List<WriterMessage> TGetList()
        {
            return _writerMessageDal.GetList();
        }

        public void TUpdate(WriterMessage t)
        {
            _writerMessageDal.Update(t);
        }
    }
}
