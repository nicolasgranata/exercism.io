export default class Words {

    public count(word:string) : Map<String, number> {
        const regex = new RegExp("");

        let words = word.split(' ');
        
        let result = new Map<string, number>();

        words.forEach(x => {
            if (!result.has(x.toLowerCase())) {
                result.set(x.toLowerCase(), 1); 
                }
            else {
                let update = result.get(x.toLowerCase())! + 1;
                result.set(x.toLowerCase(), update);
            }
        });
        
        return result;
    };
}