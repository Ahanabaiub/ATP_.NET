import axios from 'axios';
import React from 'react';
import { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { useHistory } from 'react-router-dom/cjs/react-router-dom.min';

function Orders() {

    const [orders, setOrders] = useState([]);
    const history = useHistory();
    let count = 0;

    const getOrders = async () => {
      
        try{

            let resp = await axios.get('api/orders/all');
            setOrders(resp.data);
           
        }catch(err){
            history.push({
                pathname: '/',
                state: err.response.data
            });
        }

    }
    const status = (s)=>{
        if(s==1){
            return 'Orderd';
        }
        else if(s==2){
            return 'Confirmed';
        }
        else{
            return 'Cancelled';
        }
    }

    useEffect(() => {

        getOrders();
      

    }, []);


    const cancelOrder =async (id)=>{
        //console.log('clicked '+id);

        await axios.get('api/order-cancell/'+id);
        let resp = await axios.get('api/orders/all');
        setOrders(resp.data);
    }


    
    ////............Serach............
    let handelSerach =async (e)=>{

        let query = e.target.value;

        let result = await axios.get('api/order/search/'+query);

        setOrders(result.data);

    }


    return (
        <>

            <div className='container mt-3'>
                <h1>Orders</h1>
                     
                <input className="form-control w-75  me-2 mt-5" 
                        onChange={handelSerach}  type="search" placeholder="Search Order By Date..." aria-label="Search" />

                <div>
                    <table className="table mt-4">
                        <thead>
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Customer</th>
                                <th scope="col">Service Address</th>
                                <th scope="col">Placed Date</th>
                                <th scope="col">Status</th>
                                <th scope="col"></th>
                            </tr>
                        </thead>
                        <tbody>
                            {orders.map(o=>{return <tr key={o.id}>
                                        <td>{++count}</td>
                                        <td>{o.Customer.User.name}</td>
                                        <td>{o.delevery_address}</td>
                                        <td>{o.order_place_date}</td>
                                        <td>{status(o.status)}</td>
                                        <td>
                                            <div className='d-flex'> <Link to={'/order/details/'+o.id} className='text-warning fs-2 d-block mx-5'><i className="bi bi-arrow-right-square-fill"></i></Link>
                                            {(o.status==1)?<button className='btn btn-danger '
                                            onClick={()=>cancelOrder(o.id)}
                                            >Cancell</button>:''}
                                            </div>
                                        </td>
                                    </tr>})}
                        </tbody>

                    </table>
                </div>
            </div>
        </>
    );
}

export default Orders;


                                    {/* <tr key={o.id}>
                                        <td>{++count}</td>
                                        <td>{o.Customer.userid}</td>
                                        <td>{o.delevery_address}</td>
                                        <td>{o.order_place_date}</td>
                                        <td>{o.status}</td>
                                        <td>
                                            <Link to={`/product/details/` + o.id} className="text-warning fs-3 me-5"><i className="bi bi-arrow-right-square-fill"></i></Link>
                                            <span className='text-danger fs-3' style={{ cursor: 'pointer' }} ><i className="bi bi-x-square-fill"></i></span>
                                        </td>
                                    </tr> */}

