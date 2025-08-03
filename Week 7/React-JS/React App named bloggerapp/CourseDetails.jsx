import React from 'react';

function CourseDetails({ courses }) {

return (

<div>

<h2>Course Details</h2>

<ul>

{courses.map(course => (

<li key={course.id}>

{course.name} - Duration: {course.duration} weeks

</li>

))}

</ul>

</div>

);

}