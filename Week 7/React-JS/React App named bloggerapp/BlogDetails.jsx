import React from 'react';

function BlogDetails({ blogs }) {

return (

<div>

<h2>Blog Details</h2>

{blogs.map(blog => (

<div key={blog.id} style={{ marginBottom: '1rem' }}>

<h3>{blog.title}</h3>

<p>{blog.content}</p>

</div>

))}

</div>

);

}
