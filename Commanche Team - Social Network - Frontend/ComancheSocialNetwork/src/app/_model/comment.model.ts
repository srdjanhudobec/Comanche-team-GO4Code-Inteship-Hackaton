import { creatorComment } from "./creatorComment.model";
import { User } from "./user.model";

export interface Comment {

    id: number;
    creator:creatorComment;
    commentText:string;
}