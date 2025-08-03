import React, { Component } from 'react';

import GuestPage from './Components/GuestPage';

import UserPage from './Components/UserPage';


class App extends Component {

constructor(props) {

super(props);

this.state = {

isLoggedIn: false,

};

}


handleLogin = () => {

this.setState({ isLoggedIn: true });

};


handleLogout = () => {
    this.setState({ isLoggedIn: false });

};


render() {

// Element variable

let pageContent;


if (this.state.isLoggedIn) {

pageContent = <UserPage />;

} else {

pageContent = <GuestPage />;

}


return (

<div style={{ padding: '20px', fontFamily: 'Arial' }}>

<h1> Flight Ticket Booking App</h1>


{/* Conditional Button Rendering */}

{this.state.isLoggedIn ? (

<button onClick={this.handleLogout}>Logout</button>

) : (

<button onClick={this.handleLogin}>Login</button>

)}


<hr />

{/* Conditional Page Rendering */}

{pageContent}

</div>

);

}

}