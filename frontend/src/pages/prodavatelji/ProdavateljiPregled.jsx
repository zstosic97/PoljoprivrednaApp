import { useEffect, useState } from "react";
import { Container, Table } from "react-bootstrap";
import ProdavateljiService from "../../services/ProdavateljiService";


export default function ProdavateljiPregled(){

    const[prodavatelji, setProdavatelji] = useState([]);

    async function dohvatiProdavatelje() {
       const odgovor = await ProdavateljiService.get()
       setProdavatelji(odgovor)

    }

    //hooks (kuka) se izvodi prilokom dolaska na stranicu Smjerovi
    // ovo "glumi"  konstruktor u OOP
    useEffect(()=>{
dohvatiProdavatelje();

    },[])
    
    return(
        <>
           Tablični pregled prodavatelja
            <Table striped bordered hover responsive>
                <thead>
                    <tr>

                    <th>Naziv</th>
                    <th>AdresaSjedista</th>
                    <th>Email</th>

                    </tr>
                </thead>
                <tbody>
                    {prodavatelji && prodavatelji.map((prodavatelj,index)=>(
                        <tr key={index}>
                           <td>{prodavatelj.naziv} </td>    
                           <td>{prodavatelj.adresaSjedista}</td> 
                           <td>{prodavatelj.email}</td>
                        </tr>
                    ))}
                </tbody>

            </Table>
        </>
    )
}