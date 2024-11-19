let menu = document.querySelector('#menu-btn');
let navbar = document.querySelector('.header .navbar');

menu.onclick = () => {
    menu.classList.toggle('fa-times');
    navbar.classList.toggle('active');
};
window.onscroll = () => {
    menu.classList.remove('fa-times');
    navbar.classList.remove('active');
};
/* Slides */

var swiper = new Swiper(".home-slider", {
    spaceBetween: 20,
    effect: "fade",
    grabCursor: true,
    loop: true,
    autoplay: {
        delay: 4000,
    },
    centeredSlides: true,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
});

var swiper = new Swiper(".review-slider", {
    spaceBetween: 20,
    grabCursor: true,
    loop: true,
    autoplay: {
        delay: 7500,
        disableOnInteraction: false,
    },
    breakpoints: {
        0: {
            slidesPerView: 1,
        },
        600: {
            slidesPerView: 2,
        },
    },
});

var swiper = new Swiper(".blogs-slider", {
    spaceBetween: 20,
    grabCursor: true,
    loop: true,
    autoplay: {
        delay: 7500,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        0: {
            slidesPerView: 1,
        },
        768: {
            slidesPerView: 2,
        },
        991: {
            slidesPerView: 3,
        },
    },
});

let isScrolling;
let bodyWidth = document.body.scrollWidth;
const header = document.querySelector('.header');



window.addEventListener('scroll', () => {
    const currentScrollTop = window.scrollY;

    if (currentScrollTop > 0) {
        header.style.opacity = '0.1';

    } else {
        header.style.opacity = '1';
    }

    clearTimeout(isScrolling);

    isScrolling = setTimeout(() => {
        header.style.opacity = '1';
    }, 500);
});


//*Animação Transição*//

const myObserver = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        if (entry.isIntersecting) {
            entry.target.classList.add('show')
        } else {
            entry.target.classList.remove('show')
        }
    })
})

const elements = document.querySelectorAll('.hidden')

elements.forEach((element) => myObserver.observe(element))





//*Slide Carousel*//
document.addEventListener("DOMContentLoaded", function() {
    const carouselInner = document.querySelector('.carousel-inner');
    const prevButton = document.querySelector('.prev');
    const nextButton = document.querySelector('.next');
    const items = document.querySelectorAll('.carousel-item');
    const totalItems = items.length;
    let currentIndex = 0;

    // Função para mover o carrossel
    function moveCarousel() {
        // Calcular a largura do item e do espaçamento entre eles
        const itemWidth = items[0].offsetWidth; // Largura do item (considera o gap)
        const gap = parseInt(window.getComputedStyle(items[0]).marginRight); // Espaçamento entre os itens
        const offset = -(currentIndex * (itemWidth + gap)); // Movimenta o carrossel de acordo com o índice
        carouselInner.style.transform = `translateX(${offset}px)`;
    }

    // Função para mover para o próximo item
    nextButton.addEventListener('click', function() {
        if (currentIndex < totalItems - 1) {
            currentIndex++;
        } else {
            // Se estiver no último item, volta para o primeiro
            currentIndex = 0;
        }
        moveCarousel();
    });

    // Função para mover para o item anterior
    prevButton.addEventListener('click', function() {
        if (currentIndex > 0) {
            currentIndex--;
        } else {
            // Se estiver no primeiro item, vai para o último
            currentIndex = totalItems - 1;
        }
        moveCarousel();
    });

    // Inicializa o carrossel na primeira posição
    moveCarousel();
});

