using ComancheSocialNetwork.Data;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;

namespace ComancheSocialNetwork.Repositorys.Repositorys
{
    public class AttachmentRepository : IAttachmentRepository
    {
        public readonly DatabaseContext _attachments;
        public AttachmentRepository(DatabaseContext context)
        {
            _attachments = context;
        }

        public AttachmentRepository() { }

        public AttachmentModel createAttachment(AttachmentModel attachment)
        {
            if(attachment == null)
            {
                return null;
            }
            _attachments.attachments.Add(attachment);
            _attachments.SaveChanges();
            return attachment;
        }

        public AttachmentModel deleteAttachment(int Id)
        {

            AttachmentModel a = _attachments.attachments.FirstOrDefault(x => x.Id == Id);
            if(a!= null)
            {
                _attachments.attachments.Remove(a);
                _attachments.SaveChanges() ;
                return a;
            }
            return null;

        }

        public AttachmentModel getAttachment(int Id)
        {
            AttachmentModel a = _attachments.attachments.FirstOrDefault(x=>x.Id == Id);
            if(a!=null)
            {
                return a;
            }
            return null;
        }
    }
}
