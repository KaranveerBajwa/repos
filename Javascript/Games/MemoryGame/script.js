//document.addEventListener('DOMContentLoaded', () => {
document.addEventListener('DOMContentLoaded', ()=>
{
    const cardArray =[
        {
            name: 'fries',
            img: 'images/fries.png'
        },
        {
            name: 'fires',
            img: 'images/fries.png'
        },
        {
            name: 'cheeseburger',
            img: 'images/cheeseburger.png'
        },
        {
            name: 'hotdog.png',
            img: 'images/hotdog.png'
        },
        {
            name: 'ice-cream.png',
            img: 'images/ice-cream.png'
        },        {
            name: 'milk-shake',
            img: 'images/milk-shake.png'
        },
        {
            name: 'pizza',
            img: 'images/pizza.png'    
        },
        {
            name: 'pizza',
            img: 'images/pizza.png'
        },
        {
            name: 'milk-shake',
            img: 'images/milk-shake.png'
        },
        {
            name: 'cheeseburger',
            img: 'images/cheeseburger.png'
        },
        {
            name: 'hotdog.png',
            img: 'images/hotdog.png'
        },
        {
            name: 'ice-cream.png',
            img: 'images/ice-cream.png'
        }

        
    ]
    const grid = document.querySelector('.grid');
    createBoard();
    console.log('Hello');
    function createBoard(){
        for(let i =0; i < cardArray.length; i++)
        {
            var card = document.createElement('img');
            card.setAttribute('src', 'images/blank.png');
            card.setAttribute('data-id', i);
        //   card.addEventListener('card',flipcard);
            grid.appendChild(card);
        }   
    }
    
})
