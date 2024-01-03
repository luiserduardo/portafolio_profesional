const image = document.getElementById('image');

image.addEventListener('mouseenter', () => {
  image.classList.add('hover');
});

image.addEventListener('mouseleave', () => {
  image.classList.remove('hover');
});