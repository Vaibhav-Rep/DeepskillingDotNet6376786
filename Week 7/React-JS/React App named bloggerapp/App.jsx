import React, { useState } from 'react';

import BookDetails from './Components/BookDetails';

import BlogDetails from './Components/BlogDetails';

import CourseDetails from './Components/CourseDetails';


function App() {

const [showCourses, setShowCourses] = useState(true);

const [isLoggedIn, setIsLoggedIn] = useState(false);


const books = [

{ id: 1, title: "React Basics", author: "Dan Abramov" },

{ id: 2, title: "Learning JSX", author: "Sophie Alpert" },

];


const blogs = [

{ id: 1, title: "Why React?", content: "React makes UI predictable." },

{ id: 2, title: "JSX vs HTML", content: "JSX is syntactic sugar for JS." },

];


const courses = [

{ id: 1, name: "React Fundamentals", duration: 4 },

{ id: 2, name: "Advanced Hooks", duration: 3 },

];


return (

<div style={{ padding: "20px", fontFamily: "Arial" }}>

<h1>Blogger App</h1>


{/* Toggle course visibility using && conditional */}

<button onClick={() => setShowCourses(!showCourses)}>

{showCourses ? "Hide Courses" : "Show Courses"}

</button>


{/* Ternary rendering */}

<button onClick={() => setIsLoggedIn(!isLoggedIn)} style={{ marginLeft: '10px' }}>

{isLoggedIn ? "Logout" : "Login"}

</button>


<hr />


{/* Always show */}

<BookDetails books={books} />


{/* Only show when logged in */}

{isLoggedIn ? <BlogDetails blogs={blogs} /> : <p>Please log in to see blogs.</p>}


{/* Show or hide based on boolean toggle */}

{showCourses && <CourseDetails courses={courses} />}

</div>

);

}