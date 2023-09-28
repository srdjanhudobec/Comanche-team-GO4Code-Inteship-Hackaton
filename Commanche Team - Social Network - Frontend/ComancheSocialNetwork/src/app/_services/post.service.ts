import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Post } from '../_model/post.model';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  readonly url = 'http://localhost:5204/api/Post/get-posts';

  constructor(private http: HttpClient) { }

  getAllPosts() : Observable<Post[]> {
    return this.http.get<Post[]>(this.url);
  }

  createNewPost(PostText: string) : Observable<Post> {
    return this.http.post<Post>('http://localhost:5204/api/Post/create-post', {postText: PostText});
  }

  deletePost(PostId: number) : Observable<Post> {
    return this.http.delete<any>('http://localhost:5204/api/Post/delete-post?id=' + PostId);
  }

  deleteComment(PostId:number){
    return this.http.delete<any>('http://localhost:5204/api/Comment/delete-comment?id=' + PostId);
  }

  updateComment(textComment:string,id:number){
    return this.http.put<any>('http://localhost:5204/api/Comment/update-comment?textComment=' + textComment + '&id=' + id,{});
  }
}
