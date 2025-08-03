import React from 'react';


const IndianPlayers = () => {

// Destructuring

const team = ['Player1', 'Player2', 'Player3', 'Player4', 'Player5', 'Player6'];

const [p1, p2, p3, p4, p5, p6] = team;


// Odd and Even teams

const oddTeam = [p1, p3, p5];

const evenTeam = [p2, p4, p6];


// Merging arrays

const T20players = ['Virat', 'Rohit', 'Bumrah'];

const RanjiTrophy = ['Pujara', 'Rahane'];

const allPlayers = [...T20players, ...RanjiTrophy]; // Spread operator


return (

<div>

<h2>Team Players</h2>

<p><strong>Odd Team:</strong> {oddTeam.join(', ')}</p>

<p><strong>Even Team:</strong> {evenTeam.join(', ')}</p>


<h3>Merged Players List</h3>

<ul>

{allPlayers.map((player, index) => (

<li key={index}>{player}</li>

))}

</ul>

</div>

);

};