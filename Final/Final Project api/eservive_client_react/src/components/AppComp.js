import React from 'react';
import Navbar from './Navbar';
import Sidebar from './Sidebar';
import { BrowserRouter as Router, Route, Switch } from 'react-router-dom/cjs/react-router-dom.min';
import Home from './Home';
import axios from 'axios';

axios.defaults.baseURL="https://localhost:44390/";

const AppComp=()=> {
    return ( 
        <>
             <Router>
                <Navbar />
                <Sidebar />
                 <Switch>
                     <Route exact path="/">
                        <Home />
                     </Route>
                 </Switch>
             </Router>
        </>
     );
}

export default AppComp;