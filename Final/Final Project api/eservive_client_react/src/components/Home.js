import axios from 'axios';
import React from 'react';
import { useEffect, useState } from 'react';


const Home = () => {

    const [totalCustomers,setTotalCustomers]=useState(0);
    const [totalOrders,setTotalOrders]=useState(0);
    const [totalEmployees,setTotalEmployees]=useState(0);
    const [totalServices,setTotalServices]=useState(0);


    useEffect(async () => {

        let resp = await axios.get('/api/customers/count');
        setTotalCustomers(resp.data);
       

        resp = await axios.get('api/orders/count');
        setTotalOrders(resp.data);
        

        resp = await axios.get('api/employee/count');
        setTotalEmployees(resp.data);

        resp = await axios.get('api/service/count');
        setTotalServices(resp.data);
       
        
    }, []);


    return (
        <>
            <div className='container mt-3'>

                <div className='row'>
                    <div className='col-sm-3'>
                        <div className="card bg-warning shadow" style={{width: "14rem", height:"11rem"}}>
                                <div className="card-body">
                                    <h5 className="card-title">Customers</h5>
                                    <p className="card-text mt-5 fs-1 h1">{totalCustomers}</p>
                                   
                                </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-info shadow" style={{width: "14rem", height:"11rem"}}>
                                <div className="card-body">
                                    <h5 className="card-title">Orders</h5>
                                    <p className="card-text  mt-5 fs-1 h1">{totalOrders}</p>
                                  
                                </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-danger shadow" style={{width: "14rem" , height:"11rem"}}>
                                <div className="card-body">
                                    <h5 className="card-title">Employee</h5>
                                    <p className="card-text  mt-5 fs-1 h1">{totalEmployees}</p>
                                    
                                </div>
                        </div>
                    </div>
                    <div className='col-sm-3'>
                        <div className="card bg-danger shadow" style={{width: "14rem" , height:"11rem"}}>
                                <div className="card-body">
                                    <h5 className="card-title">Services</h5>
                                    <p className="card-text  mt-5 fs-1 h1">{totalServices}</p>
                                    
                                </div>
                        </div>
                    </div>
                </div>
                <div>

                </div>

            </div>
        </>
    );
}

export default Home;