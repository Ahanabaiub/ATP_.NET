import axios from 'axios';
import React from 'react';
import { useState, useEffect } from 'react/cjs/react.development';




function Reports() {

    const [serviceExpence, setServiceExpence] = useState([]);

    const getApiData = async ()=>{
        let resp = await axios.get('api/service/service-expence-data');
        setServiceExpence(resp.data);
    }
    useEffect(() => {
        getApiData();
    }, []);
    return (
        <>
            <div className='container mt-3'>
                <h1>Reports</h1>
                <br />

                {
                    serviceExpence.map(s => {
                        return (


                            <table className="table table-bordered" key={s.name} style={{width: "65%"}}>
                               <tbody>
                               <tr>
                                    <td>Service Name :</td>
                                    <td>{s.name} Service</td>
                                </tr>
                                <tr>
                                    <td>Total Earning :</td>
                                    <td>{s.earning} BDT</td>
                                </tr>
                                <tr>
                                    <td>Total Expence :</td>
                                    <td>{s.expence} BDT</td>
                                </tr>
                                <tr>
                                   
                                    <td><b>Revenue :</b></td>
                                    <td><b>{s.earning-s.expence}  BDT</b></td>

                                </tr>
                               </tbody>
                            </table>
                        )
                    })
                }


            </div>
        </>
    );
}

export default Reports;

