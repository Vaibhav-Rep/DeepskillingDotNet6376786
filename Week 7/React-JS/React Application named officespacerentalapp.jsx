import React from 'react';


// Office Data

const officeSpaces = [

{

id: 1,

name: "Downtown Co-Work",

rent: 55000,

address: "123 Main Street, Bangalore",

image: "https://via.placeholder.com/300x200?text=Office+1"

},

{

id: 2,

name: "Tech Hub Space",

rent: 75000,

address: "456 Tech Park, Hyderabad",

image: "https://via.placeholder.com/300x200?text=Office+2"

},

{

id: 3,

name: "Startup Nest",

rent: 60000,

address: "789 Innovation Street, Pune",

image: "https://via.placeholder.com/300x200?text=Office+3"

}

];


// JSX component

function App() {

return (

<div style={{ padding: '20px', fontFamily: 'Arial' }}>

{/* JSX heading element */}

<h1>Office Space Rental Portal</h1>


{/* Render each office space */}

{officeSpaces.map(office => (

<div key={office.id} style={{

border: '1px solid #ccc',

padding: '15px',

marginBottom: '20px',

borderRadius: '8px',

backgroundColor: '#f9f9f9',

}}>

{/* JSX attributes */}

<img src={office.image} alt={office.name} style={{ width: '100%', maxWidth: '300px', borderRadius: '5px' }} />

<h2>{office.name}</h2>

<p><strong>Address:</strong> {office.address}</p>


{/* Inline CSS with conditional expression */}

<p>

<strong>Rent:</strong>{' '}

<span style={{ color: office.rent > 60000 ? 'green' : 'red' }}>

₹{office.rent.toLocaleString()}

</span>

</p>

</div>

))}

</div>

);

}