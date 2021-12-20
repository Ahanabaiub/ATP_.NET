import axios from 'axios';
import React from 'react';
import { useState, useEffect } from 'react/cjs/react.development';
import { useHistory } from 'react-router-dom/cjs/react-router-dom.min';




function Reports() {

    const [serviceExpence, setServiceExpence] = useState([]);

    const history = useHistory();

    const getApiData = async () => {

        try {

            let resp = await axios.get('api/service/service-expence-data');
            setServiceExpence(resp.data);

        } catch (err) {
            history.push({
                pathname: '/',
                state: err.response.data
            });
        }
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


                            <table className="table table-bordered" key={s.name} style={{ width: "65%" }}>
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
                                        <td><b>{s.earning - s.expence}  BDT</b></td>

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

