// Portfolio Interactive Features

// Create scroll progress indicator
const scrollProgress = document.createElement('div');
scrollProgress.className = 'scroll-progress';
document.body.appendChild(scrollProgress);

// Create page loader
const pageLoader = document.createElement('div');
pageLoader.className = 'page-loader';
pageLoader.innerHTML = `
    <div class="loader-content">
        <div class="loader-spinner"></div>
        <p>Loading Portfolio...</p>
    </div>
`;
document.body.appendChild(pageLoader);

// Hide loader when page is fully loaded
window.addEventListener('load', function() {
    setTimeout(() => {
        pageLoader.classList.add('hidden');
        setTimeout(() => {
            if (pageLoader.parentNode) {
                pageLoader.parentNode.removeChild(pageLoader);
            }
        }, 500);
    }, 800);
});

// Update scroll progress indicator
function updateScrollProgress() {
    const winScroll = document.body.scrollTop || document.documentElement.scrollTop;
    const height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
    const scrolled = (winScroll / height) * 100;
    scrollProgress.style.width = scrolled + '%';
}

document.addEventListener('DOMContentLoaded', function() {
    // Navbar scroll effect
    const navbar = document.getElementById('mainNav');
    
    window.addEventListener('scroll', function() {
        if (window.scrollY > 100) {
            navbar.classList.add('navbar-scrolled');
        } else {
            navbar.classList.remove('navbar-scrolled');
        }
        
        // Update scroll progress
        updateScrollProgress();
    });

    // Smooth scrolling for navigation links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                const offsetTop = target.offsetTop - 80; // Account for fixed navbar
                window.scrollTo({
                    top: offsetTop,
                    behavior: 'smooth'
                });
            }
        });
    });

    // Active navigation link highlighting
    const navLinks = document.querySelectorAll('.navbar-nav .nav-link');
    const sections = document.querySelectorAll('section[id]');

    function highlightNavigation() {
        let current = '';
        sections.forEach(section => {
            const sectionTop = section.offsetTop - 100;
            const sectionHeight = section.offsetHeight;
            if (window.scrollY >= sectionTop && window.scrollY < sectionTop + sectionHeight) {
                current = section.getAttribute('id');
            }
        });

        navLinks.forEach(link => {
            link.classList.remove('active');
            if (link.getAttribute('href') === `#${current}`) {
                link.classList.add('active');
            }
        });
    }

    window.addEventListener('scroll', highlightNavigation);

    // Back to top button
    const backToTopButton = document.getElementById('backToTop');
    
    window.addEventListener('scroll', function() {
        if (window.scrollY > 300) {
            backToTopButton.classList.add('show');
        } else {
            backToTopButton.classList.remove('show');
        }
    });

    backToTopButton.addEventListener('click', function() {
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });

    // Animate skill progress bars when they come into view
    const skillBars = document.querySelectorAll('.progress-bar');
    const observerOptions = {
        threshold: 0.5,
        rootMargin: '0px 0px -100px 0px'
    };

    const skillObserver = new IntersectionObserver(function(entries) {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                const progressBar = entry.target;
                const level = progressBar.getAttribute('data-level');
                progressBar.style.width = (level * 20) + '%';
                skillObserver.unobserve(progressBar);
            }
        });
    }, observerOptions);

    skillBars.forEach(bar => {
        bar.style.width = '0%';
        skillObserver.observe(bar);
    });

    // Animate counter numbers in hero stats
    function animateCounters() {
        const counters = document.querySelectorAll('.stat-number');
        const speed = 200; // Animation speed

        counters.forEach(counter => {
            const animate = () => {
                const value = parseInt(counter.getAttribute('data-target') || counter.innerText);
                const data = parseInt(counter.innerText);
                const time = value / speed;
                
                if (data < value) {
                    counter.innerText = Math.ceil(data + time);
                    setTimeout(animate, 1);
                } else {
                    counter.innerText = value + '+';
                }
            };
            animate();
        });
    }

    // Trigger counter animation when hero section is visible
    const heroSection = document.getElementById('hero');
    const heroObserver = new IntersectionObserver(function(entries) {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                animateCounters();
                heroObserver.unobserve(heroSection);
            }
        });
    }, { threshold: 0.5 });

    if (heroSection) {
        heroObserver.observe(heroSection);
    }

    // Parallax effect for hero background
    window.addEventListener('scroll', function() {
        const scrolled = window.pageYOffset;
        const heroBackground = document.querySelector('.hero-background');
        if (heroBackground) {
            heroBackground.style.transform = `translateY(${scrolled * 0.5}px)`;
        }
    });

    // Typewriter effect for hero title
    function typeWriter(element, text, speed = 100) {
        let i = 0;
        element.innerHTML = '';
        
        function type() {
            if (i < text.length) {
                element.innerHTML += text.charAt(i);
                i++;
                setTimeout(type, speed);
            }
        }
        type();
    }

    // Initialize typewriter effect for main title
    const heroTitle = document.querySelector('.hero-title span');
    if (heroTitle) {
        const originalText = heroTitle.textContent;
        setTimeout(() => {
            typeWriter(heroTitle, originalText, 100);
        }, 1000);
    }

    // Image lazy loading for project gallery
    const images = document.querySelectorAll('img[data-src]');
    const imageObserver = new IntersectionObserver(function(entries) {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                const img = entry.target;
                img.src = img.getAttribute('data-src');
                img.removeAttribute('data-src');
                imageObserver.unobserve(img);
            }
        });
    });

    images.forEach(img => imageObserver.observe(img));

    // Project card hover effects
    const projectCards = document.querySelectorAll('.project-card');
    projectCards.forEach(card => {
        card.addEventListener('mouseenter', function() {
            this.style.transform = 'translateY(-10px) scale(1.02)';
        });
        
        card.addEventListener('mouseleave', function() {
            this.style.transform = 'translateY(0) scale(1)';
        });
    });

    // Contact form validation (if you add a form later)
    const contactForm = document.getElementById('contactForm');
    if (contactForm) {
        contactForm.addEventListener('submit', function(e) {
            e.preventDefault();
            // Add form validation and submission logic here
            console.log('Form submitted');
        });
    }

    // Floating elements animation
    const floatingElements = document.querySelectorAll('.floating-tech');
    floatingElements.forEach((element, index) => {
        element.style.animationDelay = `${index * 0.5}s`;
    });

    // Enhanced copy email to clipboard functionality
    const emailLinks = document.querySelectorAll('a[href^="mailto:"]');
    emailLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            const email = this.getAttribute('href').replace('mailto:', '');
            const originalContent = this.innerHTML;
            
            // Add visual feedback
            this.style.transform = 'scale(0.95)';
            this.innerHTML = '<i class="fas fa-spinner fa-spin me-2"></i>Copying...';
            
            if (navigator.clipboard && window.isSecureContext) {
                navigator.clipboard.writeText(email).then(() => {
                    showToast('📧 Email copied to clipboard!', 'success');
                    this.innerHTML = '<i class="fas fa-check me-2"></i>Copied!';
                    this.style.transform = 'scale(1)';
                    
                    setTimeout(() => {
                        this.innerHTML = originalContent;
                        // Still open email client after delay
                        window.location.href = this.getAttribute('href');
                    }, 1500);
                }).catch(() => {
                    this.innerHTML = originalContent;
                    this.style.transform = 'scale(1)';
                    window.location.href = this.getAttribute('href');
                });
            } else {
                // Fallback for older browsers
                this.innerHTML = originalContent;
                this.style.transform = 'scale(1)';
                window.location.href = this.getAttribute('href');
            }
        });
    });

    // Toast notification function
    function showToast(message, duration = 3000) {
        const toast = document.createElement('div');
        toast.className = 'toast-notification';
        toast.innerHTML = `
            <i class="fas fa-check-circle"></i>
            <span>${message}</span>
        `;
        
        // Add toast styles
        toast.style.cssText = `
            position: fixed;
            top: 20px;
            right: 20px;
            background: var(--success-color);
            color: white;
            padding: 1rem 1.5rem;
            border-radius: 8px;
            box-shadow: 0 4px 12px rgba(0,0,0,0.2);
            z-index: 10000;
            display: flex;
            align-items: center;
            gap: 0.5rem;
            transform: translateX(100%);
            transition: transform 0.3s ease;
        `;
        
        document.body.appendChild(toast);
        
        // Animate in
        setTimeout(() => {
            toast.style.transform = 'translateX(0)';
        }, 100);
        
        // Animate out and remove
        setTimeout(() => {
            toast.style.transform = 'translateX(100%)';
            setTimeout(() => {
                document.body.removeChild(toast);
            }, 300);
        }, duration);
    }

    // Initialize AOS (Animate On Scroll) if library is loaded
    if (typeof AOS !== 'undefined') {
        AOS.init({
            duration: 1000,
            easing: 'ease-in-out',
            once: true,
            mirror: false
        });
    }

    // Dark mode toggle (optional feature)
    const darkModeToggle = document.getElementById('darkModeToggle');
    if (darkModeToggle) {
        darkModeToggle.addEventListener('click', function() {
            document.body.classList.toggle('dark-mode');
            localStorage.setItem('darkMode', document.body.classList.contains('dark-mode'));
        });

        // Check for saved dark mode preference
        if (localStorage.getItem('darkMode') === 'true') {
            document.body.classList.add('dark-mode');
        }
    }

    // Performance optimization: Debounce scroll events
    function debounce(func, wait, immediate) {
        let timeout;
        return function executedFunction() {
            const context = this;
            const args = arguments;
            const later = function() {
                timeout = null;
                if (!immediate) func.apply(context, args);
            };
            const callNow = immediate && !timeout;
            clearTimeout(timeout);
            timeout = setTimeout(later, wait);
            if (callNow) func.apply(context, args);
        };
    }

    // Apply debouncing to scroll-heavy functions
    const debouncedScroll = debounce(function() {
        highlightNavigation();
    }, 10);

    window.addEventListener('scroll', debouncedScroll);

    console.log('Portfolio JavaScript initialized successfully! 🚀');
});

// Video scroll functionality
function scrollToVideo(projectId) {
    const carousel = document.getElementById('carousel' + projectId);
    if (carousel) {
        // Find the video slide (should be the first one)
        const videoSlide = carousel.querySelector('.carousel-item video');
        if (videoSlide) {
            // Scroll to the carousel
            carousel.scrollIntoView({ behavior: 'smooth', block: 'center' });
            
            // Show the first slide (which contains the video)
            const carouselInstance = new bootstrap.Carousel(carousel);
            carouselInstance.to(0);
            
            // Optional: Play the video after a short delay
            setTimeout(() => {
                videoSlide.play().catch(err => {
                    console.log('Auto-play prevented by browser policy');
                });
            }, 500);
        }
    }
}

// Pause videos when carousel slides change
document.addEventListener('DOMContentLoaded', function() {
    const carousels = document.querySelectorAll('.carousel');
    carousels.forEach(carousel => {
        carousel.addEventListener('slide.bs.carousel', function(event) {
            // Pause all videos in this carousel
            const videos = this.querySelectorAll('video');
            videos.forEach(video => {
                video.pause();
            });
        });
    });
});
