import { Component, OnInit } from '@angular/core';
import { Post } from '../_model/post.model';
import { PostService } from '../_services/post.service';
import { CommentService } from '../_services/comment.service';
import { Comment } from '../_model/comment.model';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit {

  showUpdatePostFlag = false;
  textComment:string = "";
  commentId: number = 0;
  postId: number = 0;
  postText: string = '';
  commentText: string = '';
  posts: Post[] = [];

  constructor(
    private postService: PostService,
    private commentService: CommentService,
  ) { }

  ngOnInit(): void {
    this.getAllPosts();
  }

  addPostId(number:number){
    this.postId = number;
  }

  addCommentId(number:number){
    this.commentId = number;
  }

  deleteComment(){
    this.postService.deleteComment(this.commentId).subscribe((responseData: Post) => {
      this.getAllPosts()
    });
  }
  deletePost(){
    this.postService.deletePost(this.postId).subscribe((responseData: Post) => {
      this.getAllPosts()
    });
  }

  updateComment(){
    this.postService.updateComment(this.textComment,this.commentId).subscribe((responseData: Post) => {
      this.getAllPosts()
    });
  }

  closeUpdatePost() {
    this.showUpdatePostFlag = false;
  }

  setPostId(postId: number) {
    this.postId = postId;
  }

  getAllPosts() {
    this.postService.getAllPosts().subscribe((responseData: Post[]) => {
      this.posts = responseData;
      console.log(this.posts)
    });
    
  }

  resetModals() {
    this.postText = '';
    this.commentText = '';
    this.postId = 0;
  }

  createNewPost() {
    this.postService.createNewPost(this.postText).subscribe((responseData: Post) => {
      this.getAllPosts();
    });
  }

  createNewCommnet() {
    this.commentService.createNewComment(this.commentText, this.postId).subscribe((responseData: Comment) => {
      this.getAllPosts();
    });
  }

  // deletePost(postId: number) {
  //   this.postService.deletePost(postId).subscribe({
  //     next: (responseData) => {
  //       console.log(responseData);
  //       this.getAllPosts();
  //     },
  //     error: (error) => {
  //       if (error.status == "404") {
  //         alert("That id to delete doesnt exist!")
  //       } else {
  //         alert("Oops, something went wrong!")
  //       }
  //     }
  //   });
  // }

  // updatePost() {
  //   this.postService.updatePost(this.postId, this.postText).subscribe(resp => {
  //     this.postId = 0;
  //     this.getAllPosts();
  //   });
  // }

  // deleteComment(commentId: number) {
  //   this.commentService.deleteComment(commentId).subscribe({
  //     next: (responseData) => {
  //       console.log(responseData);
  //       this.getAllPosts();
  //     },
  //     error: (error) => {
  //       if (error.status == "404") {
  //         alert("That id to delete doesnt exist!")
  //       } else {
  //         alert("Oops, something went wrong!")
  //       }
  //     }
  //   });
  // }

  // updateComment() {
  //   this.commentService.updateComment(this.commentId, this.commentText).subscribe(resp => {
  //     this.getAllPosts();
  //   });
  // }

}
