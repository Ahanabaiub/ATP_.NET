import axios from 'axios';
import React from 'react';
import { useParams, useHistory } from 'react-router-dom/cjs/react-router-dom.min';
import { useState, useEffect } from 'react/cjs/react.development';


function OrderDetails() {

    const {id} = useParams();
    const history = useHistory();

    let count = 0;

    const [orderDetail,setOrderDetail] = useState([]);
    const [employees,setEmployees]=useState([]);

    const getOrderDetail =async ()=>{
        let resp = await axios.get('api/orders/order-detail/'+id);
        setOrderDetail(resp.data);
        //console.log(resp.data);
    }

    const getEmployees =async ()=>{    

        try{

            let resp = await axios.get('api/employee/all');
            setEmployees(resp.data);
            console.log(resp.data);
    
           
        }catch(err){
            history.push({
                pathname: '/',
                state: err.response.data
            });
        }
    }


    useEffect(() => {
       
        getOrderDetail();
        getEmployees();
       
        
    }, [history]);

    const checkEmployee=(e)=>{
        if(e){
            return e.User.name;
        }

        return "";
    }

    const assignEmployee = (e)=>{
        if(!e){
            return (<>
                <form>
                <select className="form-select"  >
            
                        
                        {
                            employees.map(cat=>(
                                <option key={cat.id} value={cat.id}>{cat.User.name}</option>
                            ))
                        }
                    </select>
                </form>
            </>)
        }
    }

    return ( 
        <>
            <div className='container mt-3'>
                    <h1>Order Details</h1>
                    <table className="table">
                        <thead>
                            <tr>
                                <th scope="col">#</th>
                                <th scope="col">Service</th>
                                <th scope="col">Quantity</th>
                                <th scope="col">Price</th>
                                <th scope="col">Employee</th>
                            </tr>
                        </thead>
                        <tbody>
                            {orderDetail.map(o=>{
                            
                               return <tr key={o.id}>
                                        <td>{++count}</td>
                                        <td>{o.Service.name}</td>
                                        <td>{o.quantity}</td>
                                        <td>{o.unit_price}</td>
                                        <td>{checkEmployee(o.Employee)}</td>
                                        <td>
                                        {assignEmployee(o.Employee)}
                                           
                                        
                                        </td>
                                    </tr>
                            })}
                        </tbody>

                    </table>
            </div>
        </>
     );
}

export default OrderDetails;

                                    // <tr key={o.id}>
                                    //     <td>{++count}</td>
                                    //     <td>{o.Service.name}</td>
                                    //     <td>{o.quantity}</td>
                                    //     <td>{o.unit_price}</td>
                                    //     <td>{(o.Employee)?o.Employee.name:''}</td>
                                    //     <td>
                                           
                                    //         <span className='text-danger btn' style={{ cursor: 'pointer' }} >Cancell</span>
                                    //     </td>
                                    // </tr>