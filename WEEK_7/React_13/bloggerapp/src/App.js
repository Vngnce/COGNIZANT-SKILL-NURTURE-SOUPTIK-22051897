import React, { useState } from 'react';
import './App.css';
import BookDetails from './components/BookDetails';
import BlogDetails from './components/BlogDetails';
import CourseDetails from './components/CourseDetails';

function App() {
  const [activeTab, setActiveTab] = useState('all'); // all, books, blogs, courses
  const [showHeader, setShowHeader] = useState(true);
  const [isDarkMode, setIsDarkMode] = useState(false);

  // Method 1: Conditional rendering with ternary operator for main content
  const renderMainContent = () => {
    return activeTab === 'all' ? (
      <div className="three-column-layout">
        <div className="column">
          <CourseDetails />
        </div>
        <div className="column">
          <BookDetails />
        </div>
        <div className="column">
          <BlogDetails />
        </div>
      </div>
    ) : (
      <div className="single-column-layout">
        {activeTab === 'courses' && <CourseDetails />}
        {activeTab === 'books' && <BookDetails />}
        {activeTab === 'blogs' && <BlogDetails />}
      </div>
    );
  };

  // Method 2: Conditional rendering with logical AND operator for tabs
  const renderTabNavigation = () => {
    const tabs = [
      { id: 'all', label: 'All Sections' },
      { id: 'courses', label: 'Courses Only' },
      { id: 'books', label: 'Books Only' },
      { id: 'blogs', label: 'Blogs Only' }
    ];

    return (
      <div className="tab-navigation">
        {tabs.map(tab => (
          <button
            key={tab.id}
            className={`tab-button ${activeTab === tab.id ? 'active' : ''}`}
            onClick={() => setActiveTab(tab.id)}
          >
            {tab.label}
          </button>
        ))}
      </div>
    );
  };

  // Method 3: Conditional rendering with switch statement for header
  const renderHeader = () => {
    if (!showHeader) return null;

    switch (activeTab) {
      case 'courses':
        return <h1>Course Management System</h1>;
      case 'books':
        return <h1>Book Catalog</h1>;
      case 'blogs':
        return <h1>Blog Platform</h1>;
      default:
        return <h1>Blogger App - Complete Dashboard</h1>;
    }
  };

  // Method 4: Conditional rendering with object mapping for theme
  const getThemeClass = () => {
    const themeConfig = {
      light: 'app-light',
      dark: 'app-dark'
    };
    return themeConfig[isDarkMode ? 'dark' : 'light'] || themeConfig.light;
  };

  // Method 5: Conditional rendering with computed properties
  const renderControls = () => {
    const hasMultipleTabs = activeTab === 'all';
    const canToggleHeader = true;
    const canToggleTheme = true;

    return (
      <div className="app-controls">
        {/* Method 6: Conditional rendering with multiple conditions */}
        {hasMultipleTabs && canToggleHeader && (
          <button onClick={() => setShowHeader(!showHeader)}>
            {showHeader ? 'Hide' : 'Show'} Header
          </button>
        )}
        
        {canToggleTheme && (
          <button onClick={() => setIsDarkMode(!isDarkMode)}>
            Switch to {isDarkMode ? 'Light' : 'Dark'} Mode
          </button>
        )}
      </div>
    );
  };

  // Method 7: Conditional rendering with early return pattern
  const renderFooter = () => {
    if (activeTab === 'all') {
      return (
        <footer className="app-footer">
          <p>Showing all sections - Use tabs above to view individual sections</p>
        </footer>
      );
    }

    return (
      <footer className="app-footer">
        <p>Currently viewing: {activeTab.charAt(0).toUpperCase() + activeTab.slice(1)} section</p>
        <button onClick={() => setActiveTab('all')}>Back to All Sections</button>
      </footer>
    );
  };

  // Method 8: Conditional rendering with array methods
  const renderQuickStats = () => {
    const stats = [
      { label: 'Active Tab', value: activeTab },
      { label: 'Header Visible', value: showHeader ? 'Yes' : 'No' },
      { label: 'Theme', value: isDarkMode ? 'Dark' : 'Light' }
    ];

    return activeTab === 'all' ? (
      <div className="quick-stats">
        <h3>Current Settings</h3>
        {stats.map((stat, index) => (
          <p key={index}>{stat.label}: {stat.value}</p>
        ))}
      </div>
    ) : null;
  };

  return (
    <div className={`App ${getThemeClass()}`}>
      {/* Method 9: Conditional rendering with state */}
      {showHeader && (
        <header className="App-header">
          {renderHeader()}
        </header>
      )}
      
      {renderTabNavigation()}
      {renderControls()}
      
      <main className="App-main">
        {renderMainContent()}
      </main>
      
      {renderQuickStats()}
      {renderFooter()}
    </div>
  );
}

export default App;
