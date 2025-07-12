import { Container } from "react-bootstrap";
import slika from '../assets/PoljoprivrednaAppSlika.jpg'

export default function Pocetna(){
    return(
        <Container className="app">
                Dobrodošli
                <img src={slika}></img>
        </Container>
    )
}