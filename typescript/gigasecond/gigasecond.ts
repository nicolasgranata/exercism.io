class Gigasecond {

    constructor( private inputDate: Date ) {
    }

    public date() {
        let result = new Date(this.inputDate);
        return new Date(result.setSeconds( result.getSeconds() + Math.pow( 10, 9) ));
    }
}

export default Gigasecond