import React from 'react';

import { BrowserRouter, Routes, Route, Link } from 'react-router-dom';

import Home from './home';

import TrainersList from './trainerlist';

import TrainerDetail from './trainerdetails';

import { trainers } from './trainersmock';

function App() {

return (

<BrowserRouter>

<div>

<nav style={{ margin: "20px" }}>

<Link to="/" style={{ marginRight: "20px" }}>Home</Link>

<Link to="/trainers">Trainers</Link>

</nav>

<Routes>

<Route path="/" element={<Home />} />

<Route path="/trainers" element={<TrainersList trainers={trainers} />} />

<Route path="/trainer/:id" element={<TrainerDetail />} />

</Routes>

</div>

</BrowserRouter>

);

}

export default App;