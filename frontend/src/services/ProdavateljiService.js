import { HttpService } from "./HttpService"

async function get(){
return await HttpService.get('/Prodavatelj')
// sve je u redu, dobili ssmo odgovor
.then((odgovor)=>{
    //console.log(odgovor.data)
    return odgovor.data
})
// nastala je greška, obradi ju
.catch((e)=>{})
}

export default{
    get
}