import React from 'react';


function BookDetails({ books }) {

return (

<div>

<h2>Book Details</h2>

<ul>

{books.map(book => (

<li key={book.id}>

<strong>{book.title}</strong> by {book.author}

</li>

))}

</ul>

</div>

);

}