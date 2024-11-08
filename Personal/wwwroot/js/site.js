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

document.addEventListener('DOMContentLoaded', function() {
    const nextButton = document.querySelector('.next');
    const prevButton = document.querySelector('.prev');
    const carouselContainer = document.querySelector('.custom-carousel');  // Altere para a classe correta
    const items = document.querySelectorAll('.carousel-item');
    let index = 0;

    // Função para atualizar a posição do carrossel
    function updateCarousel() {
        const itemWidth = items[0].offsetWidth;  // Largura de cada item
        carouselContainer.style.transform = `translateX(-${index * itemWidth}px)`;
    }

    // Navegar para o próximo item
    nextButton.addEventListener('click', function() {
        const totalItems = items.length;
        index = (index + 1) % totalItems;  // Vai para o próximo item, e volta ao começo se for o último
        updateCarousel();
    });

    // Navegar para o item anterior
    prevButton.addEventListener('click', function() {
        const totalItems = items.length;
        index = (index - 1 + totalItems) % totalItems;  // Vai para o anterior e volta para o último se for o primeiro
        updateCarousel();
    });

    // Inicializa a posição do carrossel
    updateCarousel();
});
