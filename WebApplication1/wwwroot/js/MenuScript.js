document.querySelectorAll('.tactical-card').forEach(card => {
card.addEventListener('click', () => {
// Переключаем класс открытия при клике на карточку
card.classList.toggle('is-opened');

// Дополнительный финт: меняем текст статуса в футере карточки
            const statusText = card.querySelector('.system-status');
            if (statusText) {
                if (card.classList.contains('is-opened')) {
                    statusText.textContent = 'ACCESS GRANTED';
                } else {
                    statusText.textContent = 'DATA LOCKED';
                }
            }
        });
    });
