import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Comment } from '../_model/comment.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CommentService {
  
  readonly url = 'http://localhost:5204/api/Comment/';

  constructor(private http: HttpClient) { }

  createNewComment(CommentText: string, postId: number) : Observable<Comment> {
    return this.http.post<Comment>(this.url + 'create-comment/', {commentText: CommentText, postId: postId});
  }

  deleteComment(commentId: number) {
    return this.http.delete(this.url + 'User/' + commentId);
  }

  updateComment(commentId: number, commentText: string) {
    return this.http.patch(this.url + commentId, {text: commentText});
  }

}
