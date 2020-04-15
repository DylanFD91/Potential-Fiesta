function fooBar(){

	if (2 > 1){
	    let foo = "foo";
	}
	console.log(foo);
    //foo does not exist here because of let

    if(2 > 2){
    	var bar = "bar";
    }
    console.log(bar);
    //bar DOES exist here because of var

}