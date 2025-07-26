import React, { Component } from 'react';

class Posts extends Component {
    constructor(props) {
        super(props);
        // Initialize state with a list of post objects
        this.state = {
            posts: [
                { id: 1, title: 'First Post', content: 'This is the first post.' },
                { id: 2, title: 'Second Post', content: 'Here goes the second post.' },
                { id: 3, title: 'React is Awesome', content: 'Learning React lifecycle methods.' }
            ],
            error: null
        };
    }

    // Catch errors in child components
    componentDidCatch(error, info) {
        this.setState({ error });
        alert('An error occurred: ' + error.toString());
    }

    render() {
        const { posts } = this.state;
        return (
            <div>
                {posts.map(post => (
                    <div key={post.id} style={{ marginBottom: '20px' }}>
                        <h2>{post.title}</h2>
                        <p>{post.content}</p>
                    </div>
                ))}
            </div>
        );
    }
}

export default Posts;
