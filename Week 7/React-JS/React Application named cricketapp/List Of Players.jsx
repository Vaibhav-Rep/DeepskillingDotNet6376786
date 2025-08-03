import React from 'react';


const ListofPlayers = () => {

// Using const for a constant array

const players = [

{ name: 'Virat Kohli', score: 95 },

{ name: 'Rohit Sharma', score: 88 },

{ name: 'KL Rahul', score: 45 },

{ name: 'Shubman Gill', score: 72 },

{ name: 'Hardik Pandya', score: 60 },

{ name: 'Rishabh Pant', score: 30 },

{ name: 'Ravindra Jadeja', score: 85 },

{ name: 'Bumrah', score: 75 },

{ name: 'Siraj', score: 48 },

{ name: 'Chahal', score: 65 },

{ name: 'Shami', score: 70 }

];


// Filter players with score < 70 using arrow function

const lowScorers = players.filter(player => player.score < 70);


return (

<div>

<h2>All Players (with scores)</h2>

<ul>

{players.map((player, index) => (

<li key={index}>{player.name} - {player.score}</li>

))}

</ul>


<h3>Players with score below 70</h3>

<ul>

{lowScorers.map((player, index) => (

<li key={index}>{player.name} - {player.score}</li>

))}

</ul>

</div>

);

};