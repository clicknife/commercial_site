export default class Portfolio {
    _id: string;
    title: string;
    images: Array<string>;
    description: string;
    dateEntered: Date;
    displayPosition: number;

    constructor(
    ){
        this.title = ""
        this.description = ""
        this.dateEntered = new Date()
        this.images = [];
        this.displayPosition = null;
    }

    static generateMockPortfolio() : Portfolio {
        return {
            _id: "new",
            title: "",
            description: "",
            dateEntered: new Date(),
            images: [],
            displayPosition: null
        }
    }
}
