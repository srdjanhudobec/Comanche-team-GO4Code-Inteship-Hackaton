import { Post } from "./post.model";
import { User } from "./user.model";

export interface View {
    id: number;
    userId: string;
    user: User;
    postId: string;
    post: Post
}