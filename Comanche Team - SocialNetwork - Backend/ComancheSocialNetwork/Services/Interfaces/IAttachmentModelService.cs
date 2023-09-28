using ComancheSocialNetwork.DTOs.Attachment;
using ComancheSocialNetwork.Models;

namespace ComancheSocialNetwork.Services.Interfaces
{
    public interface IAttachmentModelService
    {
        public AttachmentModelPostResponse createAttachment(AttachmentModelPostRequest attachment);

        public AttachmentModelGetResponse getAttachment(int Id);

        public AttachmentModelGetResponse deleteAttachment(int Id);
    }
}
