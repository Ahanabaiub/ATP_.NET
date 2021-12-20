import React from 'react';
import { Link } from 'react-router-dom';


const Navbar = () => {
    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-dark bg-dark fixed">
                <div className="container-fluid">
                    <a className="btn btn-dark me-2" data-bs-toggle="offcanvas" href="#offcanvasExample" role="button" aria-controls="offcanvasExample">
                        <i className="bi bi-list"></i>
                    </a>
                    <a className="navbar-brand fs-4 fw-bold" href="#">E-SHEBA</a>
                    <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span className="navbar-toggler-icon"></span>
                    </button>
                    <div className="collapse navbar-collapse" id="navbarSupportedContent">
                        <ul className="navbar-nav me-auto mb-2 mb-lg-0">
                            <li className="nav-item">
                                <Link className="nav-link active" to="/home" aria-current="page" >Home</Link>
                            </li>
                            <li className="nav-item">
                                <a className="nav-link" href="#">About</a>
                            </li>
                            
                            
                        </ul>
                        <ul className="navbar-nav mb-2 mb-lg-0">
                            <li className="nav-item">
                                {/* <a className="nav-link" aria-current="page" href="#">Name</a> */}
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to='/logout'>Logout</Link>
                            </li>
                            
                            
                        </ul>
                       
                    </div>
                </div>
            </nav>
        </>
    );
}

export default Navbar;