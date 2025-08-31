# 🚀 Professional Portfolio - Youssef Younes

A modern, responsive portfolio website built with ASP.NET Core MVC, showcasing my skills and projects as a Back-End Developer.

![Portfolio Screenshot](https://via.placeholder.com/800x400/0a0a0f/00ff88?text=Portfolio+Preview)

## ✨ Features

### 🎨 Design & UX
- **Modern Dark Tech Theme** with neon green accents
- **Fully Responsive** design for all devices
- **Smooth Animations** and micro-interactions
- **Loading Screen** with branded animation
- **Scroll Progress Indicator** for better UX
- **Interactive Elements** with hover effects

### 🛠️ Technical Features
- **ASP.NET Core MVC** architecture
- **Bootstrap 5** responsive framework
- **Custom CSS animations** and effects
- **JavaScript interactions** and smooth scrolling
- **Video integration** for project demos
- **Image carousels** for project showcases
- **Email copy-to-clipboard** functionality

### 📱 Sections
- **Hero Section** with animated profile and stats
- **About Me** with personal information and highlights
- **Skills** with animated progress bars (categorized)
- **Projects** with detailed showcases and live demos
- **Education & Certifications** with timeline
- **Contact** with multiple communication methods

## 🚀 Projects Showcased

### 1. ILLVent - Emergency & Healthcare Platform
- **Full-Stack Application** with real-time features
- **Technologies**: C#, ASP.NET Core, SignalR, Stripe, QR Codes
- **Features**: Emergency notifications, appointment booking, e-commerce

### 2. Company Administration MVC
- **Enterprise Management System**
- **Technologies**: ASP.NET Core MVC, Entity Framework, SQL Server
- **Features**: Role-based access control, CRUD operations, 12+ database tables

### 3. Personal Portfolio Website
- **Modern Web Application** (this very site!)
- **Technologies**: ASP.NET Core MVC, HTML5, CSS3, JavaScript, Bootstrap 5
- **Features**: Responsive design, animations, video integration

## 🛠️ Tech Stack

### Backend
- **C#** - Primary programming language
- **ASP.NET Core MVC** - Web framework
- **Entity Framework Core** - ORM

### Frontend
- **HTML5** - Markup
- **CSS3** - Styling with custom animations
- **JavaScript** - Interactive functionality
- **Bootstrap 5** - Responsive framework
- **Font Awesome** - Icons

### Tools & Practices
- **Git** - Version control
- **Clean Architecture** - Code organization
- **Responsive Design** - Mobile-first approach
- **Performance Optimization** - Fast loading times

## 📋 Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/MrBarbrawy/Portfolio.git
   cd Portfolio
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Run the application**
   ```bash
   dotnet run
   ```

4. **Open in browser**
   Navigate to `https://localhost:5001` or `http://localhost:5000`

## 📁 Project Structure

```
Portfolio/
├── Controllers/           # MVC Controllers
│   └── HomeController.cs
├── Models/               # ViewModels and Data Models
│   └── PortfolioViewModel.cs
├── Views/                # Razor Views
│   ├── Home/
│   │   └── Index.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/              # Static Files
│   ├── css/
│   │   └── site.css      # Custom styles
│   ├── js/
│   │   └── site.js       # Interactive features
│   └── images/           # Portfolio images
├── Program.cs            # Application entry point
└── Portfolio.csproj      # Project file
```

## 🎨 Customization

### Adding New Projects
1. Open `Controllers/HomeController.cs`
2. Add a new `Project` object to the `Projects` list in `GetPortfolioData()`
3. Include project images in `wwwroot/images/`

### Updating Personal Information
1. Modify the `PersonalInfo` object in `HomeController.cs`
2. Update skills, education, and certifications as needed

### Styling Changes
1. Edit `wwwroot/css/site.css` for visual customizations
2. Modify CSS variables at the top for color scheme changes

## 📸 Media Assets

### Required Folders
```
wwwroot/images/
├── profile/              # Profile photo
├── illvent/             # ILLVent project screenshots
└── companyadmin/        # Company Admin project assets
```

### Supported Formats
- **Images**: JPG, PNG, WebP
- **Videos**: MP4, WebM

## 🌐 Deployment

### Azure App Service
1. Publish using Visual Studio or Azure CLI
2. Configure environment variables if needed
3. Update `LiveUrl` in project data

### Other Platforms
- **Heroku**: Use buildpacks for .NET Core
- **Railway**: Deploy directly from GitHub
- **DigitalOcean**: Use App Platform for .NET

## 📱 Browser Support

- ✅ Chrome (90+)
- ✅ Firefox (88+)
- ✅ Safari (14+)
- ✅ Edge (90+)

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

## 👨‍💻 About the Developer

**Youssef Younes** - Back-End Developer  
📧 Email: [youssef.younes.dev@gmail.com](mailto:youssef.younes.dev@gmail.com)  
🔗 LinkedIn: [Connect with me](https://linkedin.com/in/youssefyounes)  
🐙 GitHub: [MrBarbrawy](https://github.com/MrBarbrawy)  

### Education
- **B.S. in Business Information Systems**
- **Helwan University** (2021-2025)
- **GPA**: 3.99/4.0

---

⭐ **Star this repository** if you found it helpful or inspiring!

📝 **Fork and customize** to create your own professional portfolio!

🤝 **Contributions welcome** - feel free to submit issues and enhancement requests!
