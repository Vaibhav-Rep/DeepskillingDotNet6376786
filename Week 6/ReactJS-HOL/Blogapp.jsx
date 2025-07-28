import React from "react";

import Posts from "./Posts";

import ErrorBoundary from "./ErrorBoundary";

function App() {

return (

<div className="App">

<ErrorBoundary>

<Posts />

</ErrorBoundary>

</div>

);

}

export default App;