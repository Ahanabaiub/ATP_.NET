import React from 'react';
import Navbar from './Navbar';
import Sidebar from './Sidebar';
import { BrowserRouter as Router, Route, Switch, Redirect } from 'react-router-dom/cjs/react-router-dom.min';
import Home from './Home';
import axios from 'axios';
import Orders from './Orders';
import OrderDetails from './OrderDetails';
import Reports from './Reports';
import Login from './Login';

axios.defaults.baseURL = "https://localhost:44390/";

const AppComp = () => {
   return (
      <>
         <Router>
            
            <Switch>
               <Route exact path="/">
                  <Login />
               </Route>
               <Route path="/home">
                  <Navbar />
                  <Sidebar />
                  <Home />
               </Route>
               <Route path="/orders">
                  <Navbar />
                  <Sidebar />
                  <Orders />
               </Route>
               <Route path="/order/details/:id">
                  <Navbar />
                  <Sidebar />
                  <OrderDetails />
               </Route>
               <Route path="/reports">
                  <Navbar />
                  <Sidebar />
                  <Reports />
               </Route>
               <Redirect to="/home" />
            </Switch>
         </Router>
      </>
   );
}

export default AppComp;