using AutoMapper;
using ComancheSocialNetwork.DTOs.Attachment;
using ComancheSocialNetwork.DTOs.User;
using ComancheSocialNetwork.Models;
using ComancheSocialNetwork.Repositorys.Interfaces;
using ComancheSocialNetwork.Services.Interfaces;
using System.Net.Mail;

namespace ComancheSocialNetwork.Services.Services
{
    public class AttachmentModelService : IAttachmentModelService
    {
        public readonly IAttachmentRepository _attachments;
        public readonly IMapper _mapper;

        public AttachmentModelService(IAttachmentRepository attachments, IMapper mapper)
        {
            _attachments = attachments;
            _mapper = mapper;
        }
        public AttachmentModelPostResponse createAttachment(AttachmentModelPostRequest attachment)
        {
            var response = _mapper.Map<AttachmentModelPostResponse>(_attachments.createAttachment(_mapper.Map<AttachmentModel>(attachment)));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public AttachmentModelGetResponse deleteAttachment(int Id)
        {
            var response = _mapper.Map<AttachmentModelGetResponse>(_attachments.deleteAttachment(Id));
            if (response == null)
            {
                return null;
            }
            return response;
        }

        public AttachmentModelGetResponse getAttachment(int Id)
        {
            var response = _mapper.Map<AttachmentModelGetResponse>(_attachments.getAttachment(Id));
            if (response == null)
            {
                return null;
            }
            return response;
        }
    }
}
