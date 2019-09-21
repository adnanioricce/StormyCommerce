import * as React from 'react';
import { useRouter } from 'next/router';
import InteractiveElement from './InteractiveElement';
import searchSVG from '../static/assets/icons/search.svg';
import api from '../services/api';

export default () => {
  const [searchResults, setSearchResults] = React.useState([]);
  const route = useRouter();
  React.useEffect(() => {
    console.log(searchResults);
  }, [searchResults]);
  async function handleChange(e) {
    const response = await api.get(`/products?search=${e.target.value}`);
    setSearchResults(response.data);
  }
  function handleSearchResultClick(name) {
    route.replace(`/products/${name.replace(/\s/g, '-')}`);
  }
  return (
    <div className="search-bar">
      <input onChange={handleChange} type="search" placeholder="Digite Aqui" />
      <InteractiveElement src={searchSVG} alt="Pesquisar" tag="img" />
      {searchResults.length > 0 && (
        <div className="search-results">
          {searchResults.map(result => (
            <InteractiveElement
              tag="div"
              key={result.id}
              onClick={() => handleSearchResultClick(result.name)}
              className="search-result"
            >
              {result.name}
            </InteractiveElement>
          ))}
        </div>
      )}
    </div>
  );
};
