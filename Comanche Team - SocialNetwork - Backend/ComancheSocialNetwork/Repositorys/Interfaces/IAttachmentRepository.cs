

using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Repositorys.Interfaces
{
    public interface IAttachmentRepository
    {
        public AttachmentModel createAttachment(AttachmentModel attachment);

        public AttachmentModel getAttachment(int Id);

        public AttachmentModel deleteAttachment(int Id);

    }
}
