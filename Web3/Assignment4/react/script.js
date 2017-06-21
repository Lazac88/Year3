var products = [{
  key: 1, 
  name: 'Cookies',
  source: './images/cookies.png',
  price: 3.29
}, {
  key: 2, 
  name: 'Ice cream',
  source: "images/icecream.png",
  price: 4.99
}, {
  key: 3, 
  name: 'Chips',
  source: "./images/chips.png",
  price: 2.29
}, {
  key: 4, 
  name: 'Donuts',
  source: "./images/donuts.png",
  price: 5.55
}
, {
  key: 5, 
  name: 'Chocolate',
  source: "./images/chocolate.png",
  price: 4.79
}

, {
  key: 6, 
  name: 'Candy',
  source: "./images/candy.png",
  price: 3.40
}
];


//ProductChooser component. Works just like an object orientated class with it's own methods
var ProductChooser = React.createClass({
  //Methods
    getInitialState: function(){
        return { total: 0 };
    },
    addToTotal: function( price )
    {
    //A state variable. Holds the total cost of items selected
        this.setState( { total: this.state.total + price } );
        
    },
  //This renders an html element that gets display in index.html
    render: function() {
        var self = this;
        var products = this.props.items.map(function(p){
            // Create a new Product component for each item in the items array.
            return <Product name={p.name} price={p.price} source={p.source} active={p.active} addToTotal={self.addToTotal} />;
        });
        return <div>
                    <h1>Shopping Cart</h1>
                    
                    <div id="products">
                        {products}
                    </div>
                    
                    
                    <p id="total">
                        <p id="totalPrice">Total Cost <b>${this.state.total.toFixed(2)}</b></p>
                    </p>
                    
                    
                </div>;
                
                
    }
});

//Product component
var Product = React.createClass({
    getInitialState: function(){
        return { active: false };
    },
    clickHandler: function (){
    //Sets boolean active to true, if product is not selected, and vice versa
        var active = !this.state.active;
    //State variable active
        this.setState({ active: active });
        
        // Notify the ProductChooser, by calling its addTotal method
    //below is an if/else statement. If active the item price is added. If !active the item price is removed
        this.props.addToTotal( active ? this.props.price : -this.props.price );
    },
  //Renders the html element
    render: function(){
        return  <p className={ this.state.active ? 'active' : '' } onClick={this.clickHandler}>
                    <img src={this.props.source}/>{this.props.name} <b>${this.props.price.toFixed(2)}</b>
                </p>;
    }
});

// Render the ProductChooser component, and pass the array of products
ReactDOM.render(
    <ProductChooser items={ products } />,
    
    
    document.getElementById('container')
);


