import { Attachment } from "./attachment.model";
import { Label } from "./label.model";
import { Rate } from "./rate.model";
import { User } from "./user.model";
import { View } from "./view.model";
import { Comment } from "./comment.model";

export interface Post {
    
    id:number;
    timeCreated: string;
    creatorId: number;
    postText: string;
    comments: Comment [];


    
}