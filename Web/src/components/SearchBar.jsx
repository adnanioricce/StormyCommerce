import * as React from 'react';
import { useRouter } from 'next/router';
import InteractiveElement from './InteractiveElement';
import searchSVG from '../static/assets/icons/search.svg';
import api from '../services/api';
import '../static/styles/components/_searchBar.scss';

export default () => {
  const [searchResults, setSearchResults] = React.useState([]);
  const [selectedResponseIndex, setSelectedResponseIndex] = React.useState(0);
  const [focus, setFocus] = React.useState(false);
  const route = useRouter();
  React.useEffect(() => {}, [searchResults]);
  async function handleChange(e) {
    if (focus) {
      const response = await api.get(`/products?search=${e.target.value}`);
      setSearchResults(response.data);
    } else {
      setSearchResults([]);
    }
  }
  function handleSearchResultClick(name) {
    route.push(`/products/${name.replace(/\s/g, '-')}`);
  }
  function handleFocus() {
    setFocus(true);
  }
  function handleBlur(e) {
    if (
      !(
        e.relatedTarget &&
        e.relatedTarget.classList &&
        [...e.relatedTarget.classList].includes('search-result')
      )
    ) {
      setFocus(false);
      setSearchResults([]);
    }
  }
  function handleKeyPress(e) {
    if (e.key === 'ArrowDown') {
      console.log('arrowdown', selectedResponseIndex, searchResults.length);
      if (selectedResponseIndex < searchResults.length - 1) {
        setSelectedResponseIndex(selectedResponseIndex + 1);
      }
    } else if (e.key === 'ArrowUp') {
      if (selectedResponseIndex > 0) {
        setSelectedResponseIndex(selectedResponseIndex - 1);
      }
    } else if (e.key === 'Enter') {
      handleSearchResultClick(searchResults[selectedResponseIndex].name);
    } else if (e.key === 'Escape') {
      e.target.blur();
    }
  }
  React.useEffect(() => {
    if (focus) {
      window.addEventListener('keydown', handleKeyPress);
    } else {
      window.removeEventListener('keydown', handleKeyPress);
    }
    return () => window.removeEventListener('keydown', handleKeyPress);
  }, [focus, searchResults, selectedResponseIndex]);
  React.useEffect(() => {
    console.log(selectedResponseIndex);
  }, [selectedResponseIndex]);
  return (
    <div className="search-bar">
      <input
        onChange={handleChange}
        onFocus={handleFocus}
        onBlur={handleBlur}
        type="search"
        placeholder="Digite Aqui"
      />
      <InteractiveElement src={searchSVG} alt="Pesquisar" tag="img" />
      {searchResults.length > 0 && (
        <div className="search-results">
          {searchResults.map((result, index) => (
            <InteractiveElement
              tag="div"
              key={result.id}
              onClick={() => handleSearchResultClick(result.name)}
              className={
                selectedResponseIndex === index
                  ? 'search-result highlighted'
                  : 'search-result'
              }
            >
              {result.name}
            </InteractiveElement>
          ))}
        </div>
      )}
    </div>
  );
};
