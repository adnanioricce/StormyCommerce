//Peguei o exemplo do auth-apollo no repositório do nextjs
import Router from 'next/router';

export default (context,target) => {
    if(context.res){
        context.res.writeHead(303,{location:target});
        context.res.end();
    } else{
        Router.replace(target);
    }
}